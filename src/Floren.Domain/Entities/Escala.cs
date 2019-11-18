using System;
using System.ComponentModel;

namespace Floren.Domain.Entities
{
    public class Escala : Entity, INotifyPropertyChanged
    {
        public int Id { get; set; }
        public int IdPlantaoUp { get; set; }
        private DateTime _semanal = DateTime.Now;
        public DateTime Semanal
        {
            get { return _semanal; }
            set
            {
                _semanal = value;
                CallPropertyChanged(nameof(Semanal));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void CallPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}