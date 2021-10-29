using Exam.Domain;
using System;
using System.Collections.Generic;

namespace Exam.Data {

  public abstract class DataManager<TID, TType> where TType : IIdentity<TID> {

    protected DataManager(IList<TType> items) {
      Items = items;
    }

    protected IList<TType> Items { get; set; }

    public void Add(TType item) {
      if (Items.Contains(item)) throw new ArgumentException("Item already exists!");
      Items.Add(item);
    }

    public void Edit(TType item) {
      if (!Items.Contains(item)) throw new ArgumentException("Such item not found");
      int index = Items.IndexOf(item);
      Items[index] = item;
    }

    public void Remove(int id) {
      TType item = Find(id);
      if (item == null) throw new ArgumentException("Such item not found");
      Items.Remove(item);
    }

    public TType Find(int id) {
      foreach (var item in Items) {
        if (item.ID.Equals(id)) return item;
      }
      return default;
    }

    public IEnumerable<TType> Get() {
      return Items;
    }
  }
}