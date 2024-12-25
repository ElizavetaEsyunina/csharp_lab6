using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace Laba_6
{
    public class Fraction : ICloneable
    {
        private int numerator;
        private int denominator;
        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }
        public int Denominator
        {
            get { return denominator; }
            set { denominator = value; }
        }

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0) throw new Exception("Знаменатель не может быть равен нулю");
            if (denominator < 0)
            {
                this.numerator = -numerator;
                this.denominator = Math.Abs(denominator);
            }
            else
            {
                this.numerator = numerator;
                this.denominator = denominator;
            }
        }

        public override string ToString()
        {
            return $"{numerator}/{denominator}";
        }

        //перегруженные операторы для выполнения действий с дробями
        public static Fraction operator +(Fraction dr1, Fraction dr2)
        {
            if (dr1.denominator == dr2.denominator)
            {
                int new_numerator = dr1.numerator + dr2.numerator;
                int new_denominator = dr1.denominator;
                Fraction new_fraction = new Fraction(new_numerator, new_denominator);
                return new_fraction;
            }
            else
            {
                //находим общий знаменатель
                int common_denominator = dr1.denominator * dr2.denominator;
                //приводим дроби к общему знаменателю
                int num1 = dr1.numerator * dr2.denominator;
                int num2 = dr2.numerator * dr1.denominator;
                //складываем числители
                int new_num = num1 + num2;
                //создаем новую дробь
                Fraction new_fraction = new Fraction(new_num, common_denominator);
                return new_fraction;
            }
        }
        public static Fraction operator +(Fraction dr, int digit)
        {
            int new_numerator = dr.numerator + (digit * dr.denominator);
            Fraction new_fraction = new Fraction(new_numerator, dr.denominator);
            return new_fraction;
        }

        public static Fraction operator -(Fraction dr1, Fraction dr2)
        {
            if (dr1.denominator == dr2.denominator)
            {
                int new_numerator = dr1.numerator - dr2.numerator;
                int new_denominator = dr1.denominator;
                Fraction new_fraction = new Fraction(new_numerator, new_denominator);
                return new_fraction;
            }
            else
            {
                //находим общий знаменатель
                int common_denominator = dr1.denominator * dr2.denominator;
                //приводим дроби к общему знаменателю
                int num1 = dr1.numerator * dr2.denominator;
                int num2 = dr2.numerator * dr1.denominator;
                //вычитаем числители
                int new_num = num1 - num2;
                //создаем новую дробь
                Fraction new_fraction = new Fraction(new_num, common_denominator);
                return new_fraction;
            }
        }
        public static Fraction operator -(Fraction dr, int digit)
        {
            int new_numerator = dr.numerator - (digit * dr.denominator);
            Fraction new_fraction = new Fraction(new_numerator, dr.denominator);
            return new_fraction;
        }

        public static Fraction operator *(Fraction dr1, Fraction dr2)
        {
            int new_numerator = dr1.numerator * dr2.numerator;
            int new_denominator = dr1.denominator * dr2.denominator;
            Fraction new_fracton = new Fraction(new_numerator, new_denominator);
            return new_fracton;
        }
        public static Fraction operator *(Fraction dr, int digit)
        {
            int new_numerator = dr.numerator * digit;
            Fraction new_fracton = new Fraction(new_numerator, dr.denominator);
            return new_fracton;
        }

        public static Fraction operator /(Fraction dr1, Fraction dr2)
        {
            int new_munerator = dr1.numerator * dr2.denominator;
            int new_denominator = dr1.denominator * dr2.numerator;
            Fraction new_fraction = new Fraction(new_munerator, new_denominator);
            return new_fraction;
        }
        public static Fraction operator /(Fraction dr, int digit)
        {
            if (digit == 0)
                throw new Exception("На ноль делить нельзя");
            int new_denominator = dr.denominator * digit;
            Fraction new_fraction = new Fraction(dr.numerator, new_denominator);
            return new_fraction;
        }

        //сравнение дробей
        public static bool operator ==(Fraction dr1, Fraction dr2)
        {
            return ((dr1.numerator == dr2.numerator) && (dr1.denominator == dr2.denominator));
        }
        public static bool operator !=(Fraction dr1, Fraction dr2)
        {
            return !(dr1 == dr2);
        }

        //клонирование дроби
        public object Clone()
        {
            return new Fraction(numerator, denominator);
        }
    }
}
