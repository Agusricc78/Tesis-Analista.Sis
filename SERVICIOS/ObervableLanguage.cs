using DALL.Mappers;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace SERVICIOS
{
    public class ObervableLanguage
    {
        private static ObervableLanguage _instancia;

        private string _idioma;

        private List<IObserver> _suscriptores = new List<IObserver>();

        private ObervableLanguage()
        {
            _idioma = null;
        }

        public static ObervableLanguage Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new ObervableLanguage();
                }

                return _instancia;
            }
        }

        public string Idioma
        {
            get => _idioma;
            set
            {
                if (value == null) return;
                if (_idioma != value)
                {
                    _idioma = value;
                    Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(_idioma);
                    NotificarSuscriptores();
                }
            }
        }

        public void Agregar(IObserver observer)
        {
            _suscriptores.Add(observer);
        }

        public void Remover(IObserver observer)
        {
            _suscriptores.Remove(observer);
        }

        public void NotificarSuscriptores()
        {
            foreach (var observer in _suscriptores)
            {
                observer.UpdateLanguage();
            }
        }
    }


}

