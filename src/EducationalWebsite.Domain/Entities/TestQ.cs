using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using EducationalWebsite.Domain.Common;
using EducationalWebsite.Domain.Entities.Questions;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace EducationalWebsite.Domain.Entities
{
    public class TestQ : BaseEntity
    
    {
        [Required(ErrorMessage = "The title is required.")]
        [StringLength(200, ErrorMessage = "The title cannot exceed 200 characters.")]
        public string Title { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "At least one quiz is required.")]
        public ICollection<Quiz> Quizzes { get; set; } = new List<Quiz>();
        
        [Required(ErrorMessage = "The user ID is required.")]
        public Guid UserId { get; set; }
        public string? Result { get; set; }

        [BsonIgnore]
        public ApplicationUser User { get; set; } = null!;
    }
}