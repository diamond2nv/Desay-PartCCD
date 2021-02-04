using Motion.BoardCard;
using Motion.Interfaces;

namespace Motion.Enginee
{
    /// <summary>
    ///     表示一个开关量。
    /// </summary>
    public class SwitchSignal : Automatic, ISignal<bool>
    {
        private readonly IoPoint _ioPoint;

        public SwitchSignal(IoPoint ioPoint)
        {
            _ioPoint = ioPoint;
        }

        /// <summary>
        ///     获取或设置信号量值
        /// </summary>
        public bool Value
        {
            get { return _ioPoint.Value; }
            set { _ioPoint.Value = value; }
        }
    }
}