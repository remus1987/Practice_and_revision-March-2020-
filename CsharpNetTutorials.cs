using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Practice_March2020
{
    class CsharpNetTutorials
    {
        public void ExersamForEach()
        {
            ArrayList list = new ArrayList();
            list.Add("Remus");
            list.Add("Andreea");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
