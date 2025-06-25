using System;

namespace ОАИП_ЛР5
{
    public static class PasswordRecoveryTimer
    {
        public static bool IsRunning { get; private set; }
        public static int SecondsRemaining { get; private set; }

        public static event Action OnTick;
        public static event Action OnComplete;

        private static System.Windows.Forms.Timer internalTimer;

        static PasswordRecoveryTimer()
        {
            internalTimer = new System.Windows.Forms.Timer();
            internalTimer.Interval = 1000;
            internalTimer.Tick += Timer_Tick;
        }

        public static void Start(int seconds, Action onTick, Action onComplete)
        {
            if (IsRunning) return;

            SecondsRemaining = seconds;
            OnTick = onTick;
            OnComplete = onComplete;

            internalTimer.Start();
            IsRunning = true;

            OnTick?.Invoke();
        }

        private static void Timer_Tick(object sender, EventArgs e)
        {
            SecondsRemaining--;

            if (SecondsRemaining > 0)
            {
                OnTick?.Invoke();
            }
            else
            {
                internalTimer.Stop();
                IsRunning = false;
                OnComplete?.Invoke();
            }
        }

        public static void Stop()
        {
            internalTimer.Stop();
            IsRunning = false;
        }
    }
}