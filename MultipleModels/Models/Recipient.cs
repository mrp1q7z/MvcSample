using System.ComponentModel.DataAnnotations;

namespace MultipleModels.Models
{
    public class Recipient
    {
        /// <summary>
        /// Recipient identifier.
        /// </summary>
        [Required]
        public int ID { get; set; }

        /// <summary>
        /// Recipient's public display name.
        /// </summary>
        [Required]
        public string PublicName { get; set; }

        /// <summary>
        /// Recipient's public display name.
        /// </summary>
        public string Email { get; set; }
    }
}