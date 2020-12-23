﻿using System.Data;
using Model;
using DataAccessLayer;
using System.Windows.Forms;

namespace BusinessLayer
{
    public sealed class BUS_Drink : BUS<BUS_Drink, Drink, int>
    {
        public override DataTable Read()
        {
            return DAL_Drink.Instance.Read();
        }
        public override void GetList(ManageList<Drink> list)
        {
            list.Clear();
            foreach (DataRow row in Read().Rows)
            {
                list.Add(new Drink(row));
            }
        }
        public override void Create(Drink newDrink)
        {
            DAL_Drink.Instance.Create(newDrink);
        }
        public override void Delete(int deleteDrinkID)
        {
            DAL_Drink.Instance.Delete(deleteDrinkID);
        }
        public override void Update(Drink updateDrink, int oldDrinkID)
        {
            DAL_Drink.Instance.Update(updateDrink, oldDrinkID);
        }
        public void QuickSort(ManageList<Drink> list, int left, int right)
        {
            if (left <= right)
            {
                int i = left, j = right;
                Drink x = list[(left + right) / 2];
                while (i <= j)
                {
                    while (list[i].Price > x.Price) i++;
                    while (list[j].Price < x.Price) j--;
                    if (i <= j)
                    {
                        Drink temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                        i++;
                        j--;
                    }
                }
                if (left < j) QuickSort(list, left, j);
                if (i < right) QuickSort(list, i, right);
            }
        }
        public void SearchDrink(string DrinkName, DataGridView dgv)
        {
            dgv.DataSource = null;
            dgv.Rows.Clear();
            dgv.DataSource = DAL_Drink.Instance.SearchDrink(DrinkName);
        }
        public void AddDrinkToComboBoxFromType(ManageList<Drink> list, ComboBox cb, string Type)
        {
            cb.Items.Clear();
            cb.Text = "";
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Type == Type)
                    cb.Items.Add(list[i].Name);
            }
        }
        public float getPrice(ManageList<Drink> list, string DrinkName)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Name == DrinkName)
                    return list[i].Price;
            }
            return 0;
        }
    }
}
