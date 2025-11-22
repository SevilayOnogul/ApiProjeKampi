using ApiProjeKampi.WebApi.Dtos.AboutDtos;
using ApiProjeKampi.WebApi.Dtos.CategoryDtos;
using ApiProjeKampi.WebApi.Dtos.FeatureDtos;
using ApiProjeKampi.WebApi.Dtos.GroupReservationDtos;
using ApiProjeKampi.WebApi.Dtos.ImageDtos;
using ApiProjeKampi.WebApi.Dtos.MessageDtos;
using ApiProjeKampi.WebApi.Dtos.NotificationDtos;
using ApiProjeKampi.WebApi.Dtos.ProductDtos;
using ApiProjeKampi.WebApi.Dtos.ReservationDtos;
using ApiProjeKampi.WebApi.Entities;
using AutoMapper;

namespace ApiProjeKampi.WebApi.Mapping
{
    public class GeneralMapping:Profile
    {
        public GeneralMapping()
        {
            CreateMap<Feature,ResultFeatureDto>().ReverseMap();
            CreateMap<Feature,CreateFeatureDto>().ReverseMap();
            CreateMap<Feature,GetByIdFeatureDto>().ReverseMap();
            CreateMap<Feature,UpdateFeatureDto>().ReverseMap();

            CreateMap<Message, CreateMessageDto>().ReverseMap();
            CreateMap<Message, GetByIdMessageDto>().ReverseMap();
            CreateMap<Message, ResultMessageDto>().ReverseMap();
            CreateMap<Message, UpdateMessageDto>().ReverseMap();

            CreateMap<Product,CreateProductDto>().ReverseMap();
            //CreateMap<Product,UpdateProductDto>().ReverseMap();
            CreateMap<Product,ResultProductWithCategoryDto>().ForMember(x=>x.CategoryName,y=>y.MapFrom(z=>z.Category.CategoryName)).ReverseMap();

            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();

            CreateMap<Notification,CreateNotificationDto>().ReverseMap();
            CreateMap<Notification,UpdateNotificationDto>().ReverseMap();
            CreateMap<Notification,ResultNotificationDto>().ReverseMap();
            CreateMap<Notification,GetNotificationByIdDto>().ReverseMap();

            CreateMap<About,CreateAboutDto>().ReverseMap();
            CreateMap<About,UpdateAboutDto>().ReverseMap();
            CreateMap<About,ResultAboutDto>().ReverseMap();
            CreateMap<About,GetAboutByIdDto>().ReverseMap();


            CreateMap<Reservation,UpdateReservationDto>().ReverseMap();
            CreateMap<Reservation,CreateReservationDto>().ReverseMap();
            CreateMap<Reservation,ResultReservationDto>().ReverseMap();
            CreateMap<Reservation,GetReservationByIdDto>().ReverseMap();


            CreateMap<Image,GetImageByIdDto>().ReverseMap();
            CreateMap<Image,ResultImageDto>().ReverseMap();
            CreateMap<Image,UpdateImageDto>().ReverseMap();
            CreateMap<Image,CreateImageDto>().ReverseMap();


            CreateMap<GroupReservation,ResultGroupReservationDto>().ReverseMap();
            CreateMap<GroupReservation,UpdateGroupReservationDto>().ReverseMap();
            CreateMap<GroupReservation,CreateGroupReservationDto>().ReverseMap();
            CreateMap<GroupReservation,GetGroupReservationByIdDto>().ReverseMap();



        }
    }
}
 