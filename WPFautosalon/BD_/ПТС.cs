//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPFautosalon.BD_
{
    using System;
    using System.Collections.Generic;
    
    public partial class ПТС
    {
        public string VIN { get; set; }
        public string Серия_Номер { get; set; }
        public string Марка { get; set; }
        public string Модель { get; set; }
        public string Тип_ТС { get; set; }
        public string Категория { get; set; }
        public string Год_Выпуска { get; set; }
        public string Модель_Двигатель { get; set; }
        public string Номер_Двигатель { get; set; }
        public string Шасси { get; set; }
        public string Кузов { get; set; }
        public string Цвет_Кузова { get; set; }
        public string Мощность_Двигатель { get; set; }
        public string Объем_Двигатель { get; set; }
        public string Макс_Масса { get; set; }
        public string Масса_Без_Нагрузки { get; set; }
        public string Страна_Изготовитель { get; set; }
        public string Экокласс { get; set; }
        public string Страна_Вывоза { get; set; }
        public string Серия_Номер_Таможни { get; set; }
        public string Таможенные_Ограничения { get; set; }
        public string ФИО_Собственника { get; set; }
        public string Адрес { get; set; }
        public string Организация_Выдавшая_ПТС { get; set; }
        public string Адрес_Организации { get; set; }
        public string Дата_Выдачи { get; set; }
    
        public virtual ТС ТС { get; set; }
    }
}
