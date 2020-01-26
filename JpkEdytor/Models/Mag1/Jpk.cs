namespace JpkEdytor.Models.Mag1
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.ObjectModel;
    using System.Xml.Serialization;

    using Common;
    using Framework;

    [GeneratedCode("xsd", "4.7.3081.0")]
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2016/03/09/03093/")]
    [XmlRoot(ElementName = "JPK", Namespace = "http://jpk.mf.gov.pl/wzor/2016/03/09/03093/", IsNullable = false)]
    public sealed class Jpk : NotifyPropertyChanged, IJpk
    {
        private Naglowek naglowek;

        private Podmiot podmiot;

        private string magazyn;

        private Pz pz;

        private bool pzSpecified;

        private Wz wz;

        private bool wzSpecified;

        private Rw rw;

        private bool rwSpecified;

        private Mm mm;

        private bool mmSpecified;

        public Jpk()
        {
            Naglowek = new Naglowek();
            Podmiot = new Podmiot()
            {
                AdresPodmiotu = new AdresPolskiV40(),
                IdentyfikatorPodmiotu = new IdentyfikatorOsobyNiefizycznejV40(),
            };
            Pz = new Pz
            {
                PzWartosc = new ObservableCollection<PzWartosc>(),
                PzWiersz = new ObservableCollection<PzWiersz>(),
            };
            Wz = new Wz
            {
                WzWartosc = new ObservableCollection<WzWartosc>(),
                WzWiersz = new ObservableCollection<WzWiersz>(),
            };
            Rw = new Rw
            {
                RwWartosc = new ObservableCollection<RwWartosc>(),
                RwWiersz = new ObservableCollection<RwWiersz>(),
            };
            Mm = new Mm
            {
                MmWartosc = new ObservableCollection<MmWartosc>(),
                MmWiersz = new ObservableCollection<MmWiersz>(),
            };
        }

        public Naglowek Naglowek
        {
            get
            {
                return naglowek;
            }
            set
            {
                naglowek = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "Podmiot1")]
        public Podmiot Podmiot
        {
            get
            {
                return podmiot;
            }
            set
            {
                podmiot = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(DataType = "token")]
        public string Magazyn
        {
            get
            {
                return magazyn;
            }
            set
            {
                magazyn = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "PZ")]
        public Pz Pz
        {
            get
            {
                return pz;
            }
            set
            {
                pz = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        public bool PzSpecified
        {
            get
            {
                return pzSpecified;
            }
            set
            {
                pzSpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "WZ")]
        public Wz Wz
        {
            get
            {
                return wz;
            }
            set
            {
                wz = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        public bool WzSpecified
        {
            get
            {
                return wzSpecified;
            }
            set
            {
                wzSpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "RW")]
        public Rw Rw
        {
            get
            {
                return rw;
            }
            set
            {
                rw = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        public bool RwSpecified
        {
            get
            {
                return rwSpecified;
            }
            set
            {
                rwSpecified = value;
                RaisePropertyChanged();
            }
        }

        [XmlElement(ElementName = "MM")]
        public Mm Mm
        {
            get
            {
                return mm;
            }
            set
            {
                mm = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        public bool MmSpecified
        {
            get
            {
                return mmSpecified;
            }
            set
            {
                mmSpecified = value;
                RaisePropertyChanged();
            }
        }
    }
}