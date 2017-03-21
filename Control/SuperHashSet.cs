using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control {
    class SuperHashSet<T> : HashSet<T> where T : class { // Ссылочное ограничение
        public SuperHashSet() : base() { }
        public SuperHashSet(IEnumerable<T> collection): base(collection) { }
        public SuperHashSet(IEqualityComparer<T> comparer): base(comparer) { }
        public SuperHashSet(IEnumerable<T> collection, IEqualityComparer<T> comparer): base(collection, comparer) { }
    }
}
