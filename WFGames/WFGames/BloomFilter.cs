using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFGames
{
    public class BloomFilter<T>
    {
        Random _random;
        int _bitSize, _numberOfHashes, _setSize;
        BitArray _bitArray;

        #region Constructors
        /// <summary>
        /// 初始化bloom滤波器并设置hash散列的最佳数目
        /// </summary>
        /// <param name="bitSize">布隆过滤器的大小(m)</param>
        /// <param name="setSize">集合的大小 (n)</param>
        public BloomFilter(int bitSize, int setSize)
        {
            _bitSize = bitSize;
            _bitArray = new BitArray(bitSize);
            _setSize = setSize;
            //用于计算布隆过滤器的最佳大小
            _numberOfHashes = OptimalNumberOfHashes(_bitSize, _setSize);
        }

        //<param name="numberOfHashes">hash散列函数的数量(k)</param>
        public BloomFilter(int bitSize, int setSize, int numberOfHashes)
        {
            _bitSize = bitSize;
            _bitArray = new BitArray(bitSize);
            _setSize = setSize;
            _numberOfHashes = numberOfHashes;
        }
        #endregion

        #region 属性
        public int NumberOfHashes
        {
            set
            {
                _numberOfHashes = value;
            }
            get
            {
                return _numberOfHashes;
            }
        }
        public int SetSize
        {
            set
            {
                _setSize = value;
            }
            get
            {
                return _setSize;
            }
        }
        public int BitSize
        {
            set
            {
                _bitSize = value;
            }
            get
            {
                return _bitSize;
            }
        }
        #endregion
        
        #region 公共方法
        public void Add(T item)
        {
            //add 用于重写的hash函数对这个传入值计算相应的哈希值。
            _random = new Random(Hash(item));

            for (int i = 0; i < _numberOfHashes; i++)
                _bitArray[_random.Next(_bitSize)] = true;
        }
        //对于传入的值是否包括进行判断
        public bool Contains(T item)
        {
            _random = new Random(Hash(item));

            for (int i = 0; i < _numberOfHashes; i++)
            {
                if (!_bitArray[_random.Next(_bitSize)])
                    return false;
            }
            return true;
        }

        //检查列表中的任何项是否可能是在集合。
        //如果布隆过滤器包含列表中的任何一项，返回真
        public bool ContainsAny(List<T> items)
        {
            foreach (T item in items)
            {
                if (Contains(item))
                    return true;
            }
            return false;
        }

        //检查列表中的所有项目是否都在集合。
        public bool ContainsAll(List<T> items)
        {
            foreach (T item in items)
            {
                if (!Contains(item))
                    return false;
            }

            return true;
        }

        /// <summary>
        /// 计算遇到误检率的概率。
        /// </summary>
        /// <returns>Probability of a false positive</returns>
        public double FalsePositiveProbability()
        {
            return Math.Pow((1 - Math.Exp(-_numberOfHashes * _setSize / (double)_bitSize)), _numberOfHashes);
        }
        #endregion

        #region 私有方法
        private int Hash(T item)
        {
            return item.GetHashCode();
        }

        //计算基于布隆过滤器散列的最佳数量
        private int OptimalNumberOfHashes(int bitSize, int setSize)
        {
            return (int)Math.Ceiling((bitSize / setSize) * Math.Log(2.0));
        }
        #endregion
    }
}
