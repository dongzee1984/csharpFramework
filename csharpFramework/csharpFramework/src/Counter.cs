using System;

namespace MathExt {

    /// <summary>
    /// 计数器
    /// </summary>
    public sealed class Counter
    {

        /// 当前值
        int _current;
        /// 上限
        int _max;
        /// 下限
        int _min;

        /// <param name="value">初始值</param>
        /// <param name="min">下限</param>
        /// <param name="max">上限</param>
        public Counter(int value, int min, int max)
        {
            _current = value;
            _min = min;
            _max = max;
        }

        public Counter()
        {
            _current = 0;
            _min = 0;
            _max = 0;
        }

        /// +
        public void Plus(int v)
        {
            _current += v;
            Clamp();
        }

        /// -v
        public void Minus(int v)
        {
            _current -= v;
            Clamp();
        }

        /// 当前值
        public int current
        {
            get
            {
                return _current;
            }
        }

        /// 到达上限
        /// 用于计数类目标达成
        public bool ReachMax()
        {
            return _current >= _max;
        }

        /// 到达下限
        /// 用于计数类耗尽
        public bool ReachMin()
        {
            return _current <= _min;
        }

        /// 修正数据在给定区间内
        public void Clamp()
        {
            _current = Math.Max(_min, Math.Min(_max, _current));
        }

        /// 显示字符串
        /// _current/_max
        public string GetProgressText()
        {
            return _current + "/" + _max;
        }

        /// 显示字符串
        /// _current
        public string GetText()
        {
            return _current.ToString();
        }
    }
}

