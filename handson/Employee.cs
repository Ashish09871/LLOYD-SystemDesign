using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    public class Employee
    {
        //Value type Property
        string _name;
        int _id;
        public string Name { get => _name;}
        public int EmpId { get => _id; }
        public void Init(String n)
        {
            //this.EmpId = CreateEmpId();
            this._name = n; //Data Abstraction
            this._id = this.CreateEmpId();//Process Abstraction
            // return this.Name;
        }

        private int CreateEmpId()
        {
            return 1;
        }
    }
}
