using System;
using System.Collections.Generic;

namespace Enemies
{
    [Serializable]
    public class Wave
    {
        public List<EnemyType> _types = new List<EnemyType>();
        public List<int> _countOfType = new List<int>();
    }
}