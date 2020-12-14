using System;


namespace IdakeFitness.BL.Model
{
    /// <summary>
    /// Пол.
    /// </summary>
    public class Gender
    {
        /// <summary>
        /// Имя пола.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Создать новый пол.
        /// </summary>
        /// <param name="name"> Пол. </param>
        public Gender(string name)
        {
            Name = name ?? throw new ArgumentNullException("Имя гендера не может быть пустым или null" ,nameof(name));
        }

        public override string ToString()
        {
            return Name;
        }
    }

}
