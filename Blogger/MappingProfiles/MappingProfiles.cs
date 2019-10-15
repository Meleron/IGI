using AutoMapper;
using Blogger.Mapped;
using Blogger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blogger.MappingProfiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<User, UserModel>();
            CreateMap<UserModel, User>()
                .ForMember(m => m.CommentList, options => options.Ignore());
            CreateMap<Post, PostModel>();
            CreateMap<PostModel, Post>()
                .ForMember(m => m.CommentList, options => options.Ignore());
        }
    }
}
