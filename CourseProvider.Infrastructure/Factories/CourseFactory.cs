using Azure.Core;
using CourseProvider.Infrastructure.Data.Entities;
using CourseProvider.Infrastructure.Models;

namespace CourseProvider.Infrastructure.Factories;

public static class CourseFactory
{
    public static CourseEntity Create(CourseCreateRequest request)
    {
        return new CourseEntity
        {
            image = request.image,
            bigImage = request.bigImage,
            isBestSeller = request.isBestSeller,
            isDigital = request.isDigital,
            categories = request.categories,
            title = request.title,
            ingress = request.ingress,
            starRating = request.starRating,
            reviews = request.reviews,
            likesInProcent = request.likesInProcent,
            likesInNumbers = request.likesInNumbers,
            hours = request.hours,
            Authors = request.Authors?.Select(a => new AuthorEntity
            {
                author = a.author
            }).ToList(),
            Prices = request.Prices == null ? null : new PricesEntity
            {
                currency = request.Prices.currency,
                price = request.Prices.price,
                discountPrice = request.Prices.discountPrice,
            },
            Content = request.Content == null ? null : new ContentEntity
            {
                description = request.Content.description,
                includes = request.Content.includes,
                ProgramDetails = request.Content.ProgramDetails?.Select(pd => new ProgramDetailItemEntity
                {
                    id = pd.id,
                    title = pd.title,
                    description = pd.description
                }).ToList()
            }


        };
    }


    public static CourseEntity Create(CourseUpdateRequest request)
    {
        return new CourseEntity
        {
            id = request.id,
            image = request.image,
            bigImage = request.bigImage,
            isBestSeller = request.isBestSeller,
            isDigital = request.isDigital,
            categories = request.categories,
            title = request.title,
            ingress = request.ingress,
            starRating = request.starRating,
            reviews = request.reviews,
            likesInProcent = request.likesInProcent,
            likesInNumbers = request.likesInNumbers,
            hours = request.hours,
            Authors = request.Authors?.Select(a => new AuthorEntity
            {
                author = a.author
            }).ToList(),
            Prices = request.Prices == null ? null : new PricesEntity
            {
                currency = request.Prices.currency,
                price = request.Prices.price,
                discountPrice = request.Prices.discountPrice,
            },
            Content = request.Content == null ? null : new ContentEntity
            {
                description = request.Content.description,
                includes = request.Content.includes,
                ProgramDetails = request.Content.ProgramDetails?.Select(pd => new ProgramDetailItemEntity
                {
                    id = pd.id,
                    title = pd.title,
                    description = pd.description
                }).ToList()
            }


        };
    }

    public static Course Create(CourseEntity entity)
    {
        return new Course
        {
            id = entity.id,
            image = entity.image,
            bigImage = entity.bigImage,
            isBestSeller = entity.isBestSeller,
            isDigital = entity.isDigital,
            categories = entity.categories,
            title = entity.title,
            ingress = entity.ingress,
            starRating = entity.starRating,
            reviews = entity.reviews,
            likesInProcent = entity.likesInProcent,
            likesInNumbers = entity.likesInNumbers,
            hours = entity.hours,
            Authors = entity.Authors?.Select(a => new Author
            {
                author = a.author
            }).ToList(),
            Prices = entity.Prices == null ? null : new Prices
            {
                currency = entity.Prices.currency,
                price = entity.Prices.price,
                discountPrice = entity.Prices.discountPrice,
            },
            Content = entity.Content == null ? null : new Content
            {
                description = entity.Content.description,
                includes = entity.Content.includes,
                ProgramDetails = entity.Content.ProgramDetails?.Select(pd => new ProgramDetailItem
                {
                    id = pd.id,
                    title = pd.title,
                    description = pd.description
                }).ToList()
            }


        };
    }

}



