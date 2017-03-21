using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control {
    class Time {
        public const int Hours = 1;
        public int Minutes;
        public int Seconds;

        public Time(int minutes, int seconds) {
            this._Minutes = minutes;
            this._Seconds = seconds;
        }
        public int _Minutes {
            get { return Minutes; }
            set {
                if (value < 60) {
                    Minutes = value;
                } else throw new Exception("Minutes isn't rigth value.");
            }
        }
        public int _Seconds {
            get { return Seconds; }
            set {
                if (value < 60) {
                    Seconds = value;
                } else throw new Exception("Seconds isn't rigth value.");
            }
        }
        public static bool operator < (Time t1, Time t2) {
            if (t1.Minutes < t2.Minutes) {
                return true;
            }
            if (t1.Minutes == t2.Minutes) {
                if (t1.Seconds < t2.Seconds) { return true; }
            }
            return false;
        }
        public static bool operator >(Time t1, Time t2) {
            if (t1.Minutes > t2.Minutes) {
                return true;
            }
            if (t1.Minutes == t2.Minutes) {
                if (t1.Seconds > t2.Seconds) { return true; }
            }
            return false;
        }
        public static bool operator == (Time t1, Time t2) {
            if(t2.Equals(t1)) { return true; }
            return false;
            }
        public static bool operator !=(Time t1, Time t2) {
            return !(t1 == t2);
        }

        public override string ToString() {
            return Hours + ":" + Minutes + ":" + Seconds;
        }
    }
}