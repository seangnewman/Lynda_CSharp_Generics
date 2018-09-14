using System;
using System.Collections;
using System.Collections.Generic;

namespace Waste
{
    public class MultiSlot
    {
        public IList<Food> Foods { get; } = new List<Food>();
        public IList<Trash> Waste{ get; } = new List<Trash>();
        public IList<Bottle> Bottles { get; } = new List<Bottle>();
        public IList<Soda> Liquids { get; } = new List<Soda>();

        
        public void processAll()
        {
            Process<Food> (Foods, (food) =>{
                Composter.GrowKale(food);
                });
            Process<Trash>(Waste, (trash) => {
                SmartIncinerator.Burn(trash);
            } );
            Process<Bottle>(Bottles, (bottle)=>{
                Melter.MakeFidgetSpinner(bottle);
            });
            Process<Soda>(Liquids, (soda)=> {
                Sponge.SoakUp(soda);
            });
        }

        public void Process<T>(IList<T> Items, Action<T> disposalMethod)
        {
            foreach(var item in Items)
            {
                disposalMethod(item);
                
            }
        }
    }

}
