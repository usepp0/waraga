//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace toursapp2
{
    using System;
    using System.Collections.Generic;
    
    public partial class TypeOfTour
    {
        public int TourId { get; set; }
        public string TypeId { get; set; }
    
        public virtual tours tours { get; set; }
    }
}
