using System;
using System.Threading;

namespace Homework
{
    /// <summary>
    /// class imitates a timer with functionality of sending messages on signal event
    /// </summary>
    public class Timer
    {
        /// <summary>
        /// message for a listener
        /// </summary>
        private string message;

        /// <summary>
        /// start time
        /// </summary>
        private byte seconds;

        /// <summary>
        /// creates a timer with specified message to send and start time
        /// </summary>
        /// <param name="message">message for a listener</param>
        /// <param name="seconds">start time</param>
        public Timer(string message, byte seconds)
        {
            this.message = message;
            this.seconds = seconds;
        }

        /// <summary>
        /// event on finishing timer countdown
        /// </summary>
        public event EventHandler<SignalEventArgs> Signal;

        /// <summary>
        /// starts timer countdown
        /// </summary>
        public void StartCountdown()
        {
            new Thread(() =>
            {
                Thread.Sleep(TimeSpan.FromSeconds(seconds));
                OnSignal(this, new SignalEventArgs(message));
            }).Start();
        }

        /// <summary>
        /// notifies signal event listeners
        /// </summary>
        /// <param name="sender">object that generates an event</param>
        /// <param name="e">signal event arguments</param>
        protected virtual void OnSignal(object sender, SignalEventArgs e)
        {
            Signal?.Invoke(sender, e);
        }

        /// <summary>
        /// signal event arguments
        /// </summary>
        public class SignalEventArgs : EventArgs
        {
            /// <summary>
            /// constructs an instance with event message
            /// </summary>
            /// <param name="message"></param>
            public SignalEventArgs(string message)
            {
                this.Message = message;
            }

            /// <summary>
            /// transmitted message
            /// </summary>
            public string Message { get; private set; }

            /// <summary>
            /// additional info
            /// </summary>
            public DateTime Now { get => DateTime.Now; }
        }
    }
}
