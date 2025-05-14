using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaburi.Components
{
    public delegate void CountDownTickEventHandler(int remainingSeconds);
    [DefaultEvent("Tick")]
    public partial class CountDownTimer: Component
    {
        // 남은 시간
        private int _remainingSeconds;

        private void Timer1_Tick(object? sender, EventArgs e)
        {
            Tick?.Invoke(--_remainingSeconds);
            if (_remainingSeconds == 0)
            {
                CountdownEnded?.Invoke();
                timer1.Stop();
            }
        }

        public event CountDownTickEventHandler? Tick;
        public event Action? CountdownEnded;

        public CountDownTimer()
        {
            InitializeComponent();
        }

        public CountDownTimer(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            timer1.Tick += Timer1_Tick;
        }

        [DefaultValue(30), Description("카운트다운 시작 시간")]
        public int WaitSeconds { get; set; } = 30;

        public void Start()
        {
            _remainingSeconds = WaitSeconds;
            Tick?.Invoke(_remainingSeconds);
            timer1.Start();
        }

        public void Stop()
        {
            timer1.Stop();
        }
    }
}
