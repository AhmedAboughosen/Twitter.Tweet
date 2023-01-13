using System;
using Core.Domain.Enums;
using Core.Domain.Models.DTO.RequestDTO;

namespace Core.Domain.Entities
{
    public class Tweet
    {
        public Guid Id { get; private set; }

        public TweetContentTypes ContentTypes { get; private set; }

        public string Content { get; private set; }


        public Guid UserId { get; private set; }
        public User User { get; private set; }


        public Tweet(AddNewTweetRequestDto dto)
        {
            Id = Guid.NewGuid();
            ContentTypes = dto.ContentTypes;
            Content = dto.Content;
            UserId = dto.UserId;
        }

        public Tweet()
        {
        }
    }
}