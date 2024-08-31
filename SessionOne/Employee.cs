namespace SessionOne
{
    public class BaseEntity
    {
        public Guid Id { get; protected set; } = Guid.NewGuid();

        public bool IsDeleted { get; private set; } = false;

        public DateTime? DeleteTime { get; private set; }

        public Guid? DeleterId { get; private set; }

        public void SetIsDeleted(Guid deleterId)
        {
            IsDeleted = true;
            DeleterId = deleterId;
            DeleteTime = DateTime.Now;
        }
    }

    public abstract class Person : BaseEntity
    {
        public string Name { get;  set; }

        public int IdNumber { get; private set; }

        public virtual int SetIdNumber(int idNumber)
        {
            if (idNumber < 0)
            {
                throw new ArgumentException("Id Number less than Zero");
            }

            if (idNumber == 0)
            {
                throw new ArgumentException("Zero");
            }

            if (IdNumber > 0)
            {
                return IdNumber;
            }

            IdNumber = idNumber;

            return IdNumber;
        }
    }

    public class Employee : Person
    {
        public decimal Salary { get; set; }

        public decimal SetSalary(decimal? salary = null, decimal? salaryFromConfiguration = null)
        {
            if (salaryFromConfiguration is null && salary is null)
            {
                throw new Exception(Constants.NoSalary);
            }

            if (salary is null)
            {
                Salary = salaryFromConfiguration.Value;
                // return Salary;
            }

            this.Salary = salary.Value;

            return Salary;
        }
        //Address 
        //Department
        // photo
    }

    public class Student : Person
    {
        public string Level { get; set; }
    }


}
