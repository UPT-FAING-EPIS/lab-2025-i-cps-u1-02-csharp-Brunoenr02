namespace Bank.WebApi.Models
{
    /// <summary>
    /// Representa una cuenta bancaria con operaciones de débito y crédito.
    /// </summary>
    public class BankAccount
    {
        private readonly string m_customerName;
        private double m_balance;

        /// <summary>
        /// Constructor privado requerido por algunos frameworks.
        /// </summary>
        private BankAccount() { }
        
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="BankAccount"/>.
        /// </summary>
        /// <param name="customerName">Nombre del cliente.</param>
        /// <param name="balance">Balance inicial de la cuenta.</param>
        public BankAccount(string customerName, double balance)
        {
            m_customerName = customerName;
            m_balance = balance;
        }
        
        /// <summary>
        /// Obtiene el nombre del cliente.
        /// </summary>
        public string CustomerName { get { return m_customerName; } }
        
        /// <summary>
        /// Obtiene el balance actual de la cuenta.
        /// </summary>
        public double Balance { get { return m_balance; }  }
        
        /// <summary>
        /// Debita una cantidad especificada de la cuenta.
        /// </summary>
        /// <param name="amount">Cantidad a debitar.</param>
        public void Debit(double amount)
        {
            if (amount > m_balance)
                throw new ArgumentOutOfRangeException("amount");
            if (amount < 0)
                throw new ArgumentOutOfRangeException("amount");
            m_balance -= amount;
        }
        
        /// <summary>
        /// Acredita una cantidad especificada en la cuenta.
        /// </summary>
        /// <param name="amount">Cantidad a acreditar.</param>
        public void Credit(double amount)
        {
            if (amount < 0)
                throw new ArgumentOutOfRangeException("amount");
            m_balance += amount;
        }
    }
}