﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication7.Models
{
    public class ReviewViewModel
    {
        public ReviewViewModel()
        {
        }

        public ReviewViewModel(Review review)
        {
            if (review == null)
            {
                return;
            }

            BookId = review.BookId;
            Rating = review.Rating;
            Description = review.Description;
        }

        public int BookId { get; set; }
        public int Rating { get; set; }
        public string Description { get; set; }

        public Review ToReview()
        {
            return new Review
            {
                BookId = BookId,
                Description = Description,
                Rating = Rating
            };
        }
    }
}