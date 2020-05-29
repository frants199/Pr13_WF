using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;

namespace Pr13_WF
{
	abstract class Trans
	{
		public abstract void info(DataGridViewRow row);
		public abstract double get_capasity();
	
	}
	class Car : Trans
	{
		private string mark_;
		private string number_;
		private double capasity_;
		public Car() { }
		public Car(string mark, string number, double capasity)
		{
			mark_ = mark;
			number_ = number;
			capasity_ = capasity;
		}
		public override void info(DataGridViewRow row)
		{
			row.Cells["Mark"].Value = mark_;
			row.Cells["Number"].Value = number_;
			row.Cells["Capasity"].Value = capasity_;
		}
		public override double get_capasity()
		{
			return capasity_;
		}
	}
	class Motorcycle : Trans
	{
		private string mark_;
		private string number_;
		private double capasity_;
		private bool stroller_;
		public Motorcycle() : base() { }
		public Motorcycle(string mark, string number, double capasity, bool stroller)
		{
			mark_ = mark;
			number_ = number;
			capasity_ = capasity;
			stroller_ = stroller;
			if (!stroller_) capasity_ = 0;
		}
		public override void info(DataGridViewRow row)
		{
			row.Cells["Mark"].Value = mark_;
			row.Cells["Number"].Value = number_;
			row.Cells["Capasity"].Value = capasity_;
			row.Cells["Stroller"].Value = stroller_;
		}
		public override double get_capasity()
		{
			return capasity_;
		}
	}
	class Truck : Trans
	{
		protected string mark_;
		protected string number_;
		protected double capasity_;
		private bool trailer_;
		public Truck() : base() { }
		public Truck(string mark, string number, double capasity, bool trailer)
		{
			mark_ = mark;
			number_ = number;
			capasity_ = capasity;
			trailer_ = trailer;
			if (trailer_) capasity *= 2;
		}
		public override void info(DataGridViewRow row)
		{
			row.Cells["Mark"].Value = mark_;
			row.Cells["Number"].Value = number_;
			row.Cells["Capasity"].Value = capasity_;
			row.Cells["Trailer"].Value = trailer_;
		}
		public override double get_capasity()
		{
			return capasity_;
		}
	}
}
