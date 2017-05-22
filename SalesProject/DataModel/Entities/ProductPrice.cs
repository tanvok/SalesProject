﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesProject.DataModel
{
    public partial class ProductPrice
    {
        public override string ToString()
        {
            return Price.ToString("F2") +"р./ " + Product.MeasureSmallString+ " с " + DateBegin.ToShortDateString();
        }

        
    }
}
