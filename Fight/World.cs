using System;
using System.Collections.Generic;
using System.Text;

namespace Fight
{
    class World
    {
        private List<IUpdate> elements = new List<IUpdate>();

        public void AddElement(IUpdate elenent)
        {
            elements.Add(elenent);
        }

        public void Update()
        {
           
           foreach (var el in elements)
                {
                    el.Update();
                }  
                             
        }

        public void LateUpdate()
        {
            foreach (var el in elements)
            {
                el.LateUpdate();
            }
        }



    }
}
