//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace КурсоваяWPF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Userss
    {
        public int id { get; set; }
        public int idRolles { get; set; }
        public string password { get; set; }
        public string login { get; set; }
    
        public virtual Rolles Rolles { get; set; }
    }
}
