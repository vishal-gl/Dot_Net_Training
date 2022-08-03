using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAppwithInterface
{
    interface Interface1
    {
         Student[] createContact(Student[] arr);
    }
    interface Interface2
    {
        void Update(Student[] array);
    }
    interface Interface3
    {
        void Delete1(Student[] array);
    }



    
}
