using System;
using System.Collections.Generic;
using System.Text;

namespace MB.Domain.ArticleCategoryAgg.Exeptions
{
  public  class DuplicatedRecordExeption : Exception
    {
        public DuplicatedRecordExeption()
        {
                
        }
        public DuplicatedRecordExeption(string message) : base(message)
        {

        }
    }
}
