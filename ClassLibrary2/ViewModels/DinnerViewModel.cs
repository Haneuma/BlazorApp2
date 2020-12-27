using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp2.Data
{
    public interface IDinnerViewModel
    {
        List<Dinner> Dinners { get; }
        Task GetDinnersAsync();
    }

    public class DinnerViewModel:IDinnerViewModel
    {
        private IDinnerModel dinnerModel;
        private List<Dinner> dinners;


        public List<Dinner> Dinners
        {
            get => dinners;
            set => dinners = value;
        }

        public DinnerViewModel(IDinnerModel dinnerModel)
        {
            this.dinnerModel = dinnerModel;
        }
        public async Task GetDinnersAsync()
        {
            this.dinners = await dinnerModel.GetDinnerAsync();
        }
    }
}
