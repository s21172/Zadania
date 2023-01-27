using System;

namespace LinqConsoleApp
{
    public class Emp
    {
        public int Empno { get; set; }
        public string Ename { get; set; }
        public string Job { get; set; }
        public int Salary { get; set; }
        public DateTime? HireDate { get; set; }
        public int? Deptno { get; set; }
        public Emp Mgr { get; set; }

        public override string ToString()
        {
            return $"{Empno}\t{Ename}\t{Job}\t{Salary}\t{HireDate}\t{Deptno}\t{Mgr?.Empno}";
        }
    }
}