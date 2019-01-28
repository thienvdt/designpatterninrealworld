using System;
using System.Collections.Generic;
//Save state of an object
namespace Memeto
{
    public class UserLogin : ICloneable
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public object Clone()
        {
            return new UserLogin
            {
                Id = this.Id,
                Name = this.Name
            };
        }
        public override string ToString()
        {
            return $"ID: {this.Id} /Name {this.Name}";
        }
        public class Memento<T> where T: ICloneable
        {
            private T UserLogin { get; set; }
            public T GetState() {
                return UserLogin;
            }                                     
            public void SetState(T userLogin) {
                UserLogin = (T)userLogin.Clone();
            }
        }
        public class Originator<T> where T: ICloneable
        {
            private T StateObj { get; set; }
            public Memento<T> CreateMemento()
            {
                Memento<T> m = new Memento<T>();
                m.SetState(this.StateObj);
                return m;
            }
            public void RestoreMemento(Memento<T> m) {
                this.StateObj = m.GetState();
            }
            public void SetState(T state) {
                this.StateObj = state;
            }
            public void ShowState()
            {
                Console.WriteLine(this.StateObj.ToString());
            }
        }
        public static class CareTaker<T> where T : ICloneable {
            private static List<Memento<T>> mementoLst = new List<Memento<T>>();
            public static void SaveState(Originator<T> orig) {
                mementoLst.Add(orig.CreateMemento());
            }
            public static void RestoreState(Originator<T> orig, int checkpoint) {
              orig.RestoreMemento(mementoLst[checkpoint]);
            }
        }
    }
}
