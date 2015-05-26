using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MultipleModels.Models
{
    public class Message
    {
        /// <summary>
        /// Message identifier. Only set when fetching messages.
        /// </summary>
        public int? ID { get; set; }

        /// <summary>
        /// Message title.
        /// </summary>
        [Required]
        public string Title { get; set; }

        /// <summary>
        /// Message body.
        /// </summary>
        [Required]
        public string Body { get; set; }

        /// <summary>
        /// A list of message recipients.
        /// </summary>
        [Required]
        public List<Recipient> Recipients { get; set; }
    }
}