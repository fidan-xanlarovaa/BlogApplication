using Blog.Shared.Localization;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entities.Dtos.User
{
    public class UserUpdateDto
    {
        [Required]
        public int Id { get; set; }

        [Display(ResourceType = typeof(BaseLocalization), Name = nameof(BaseLocalization.NoDataAvailableOnRequest))]//BaseLocalization..Username
        [Required(ErrorMessageResourceType = typeof(BaseLocalization), ErrorMessageResourceName = nameof(BaseLocalization.NoDataAvailableOnRequest))]//BaseLocalization.RequiredErrorMessage
        [MaxLength(50, ErrorMessageResourceType = typeof(BaseLocalization), ErrorMessageResourceName = nameof(BaseLocalization.NoDataAvailableOnRequest))]//BaseLocalization.MaxLengthErrorMessage
        [MinLength(3, ErrorMessageResourceType = typeof(BaseLocalization), ErrorMessageResourceName = nameof(BaseLocalization.NoDataAvailableOnRequest))]//BaseLocalization.MinLengthErrorMessage
        public string UserName { get; set; }

        [Display(ResourceType = typeof(BaseLocalization), Name = nameof(BaseLocalization.NoDataAvailableOnRequest))]//BaseLocalization.Email
        [Required(ErrorMessageResourceType = typeof(BaseLocalization), ErrorMessageResourceName = nameof(BaseLocalization.NoDataAvailableOnRequest))]//BaseLocalization.RequiredErrorMessage
        [MaxLength(100, ErrorMessageResourceType = typeof(BaseLocalization), ErrorMessageResourceName = nameof(BaseLocalization.NoDataAvailableOnRequest))]//BaseLocalization.MaxLengthErrorMessage
        [MinLength(10, ErrorMessageResourceType = typeof(BaseLocalization), ErrorMessageResourceName = nameof(BaseLocalization.NoDataAvailableOnRequest))]//BaseLocalization.MinLengthErrorMessage
        [DataType(DataType.EmailAddress, ErrorMessage = "")]
        public string Email { get; set; }

        /// <summary>
        /// +99455 666 66 66
        /// </summary>
        [Display(ResourceType = typeof(BaseLocalization), Name = nameof(BaseLocalization.NoDataAvailableOnRequest))]// BaseLocalization.PhoneNumber
        [Required(ErrorMessageResourceType = typeof(BaseLocalization), ErrorMessageResourceName = nameof(BaseLocalization.NoDataAvailableOnRequest))]// BaseLocalization.RequiredErrorMessage
        [MaxLength(13, ErrorMessageResourceType = typeof(BaseLocalization), ErrorMessageResourceName = nameof(BaseLocalization.NoDataAvailableOnRequest))]//BaseLocalization.MaxLengthErrorMessage
        [MinLength(13, ErrorMessageResourceType = typeof(BaseLocalization), ErrorMessageResourceName = nameof(BaseLocalization.NoDataAvailableOnRequest))]//BaseLocalization.MinLengthErrorMessage
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [DataType(DataType.Upload)]
        public IFormFile File { get; set; }
        public string Avatar { get; set; }
    }
}
