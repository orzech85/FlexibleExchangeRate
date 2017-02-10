using FlexibleExchangeRate.Core.Model;
using FlexibleExchangeRate.Core.NbpApi;
using MvvmCross.Core.ViewModels;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleExchangeRate.Core.ViewModels
{
    public class CurrenciesViewModel
        : MvxViewModel
    {
        INbpApi _nbpApi;

        public CurrenciesViewModel()
        {
        }

        public override async void Start()
        {
            _nbpApi = RestService.For<INbpApi>("http://api.nbp.pl/api");
            Rates = new MvxObservableCollection<Rate>((await _nbpApi.GetTable("A")).FirstOrDefault().rates);
        }

        private MvxObservableCollection<Rate> _rates;
        public MvxObservableCollection<Rate> Rates {
            get { return _rates; }
            set { SetProperty(ref _rates, value); }
        }
    }
}
