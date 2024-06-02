using CourseProvider.Infrastructure.Data.Entities;

namespace CourseProvider.Infrastructure.GraphQL.ObjectTypes;

public class CourseType : ObjectType<CourseEntity>
{
    protected override void Configure(IObjectTypeDescriptor<CourseEntity> descriptor)
    {
        descriptor.Field(c => c.id).Type<NonNullType<IdType>>();
        descriptor.Field(c => c.isBestSeller).Type<BooleanType>();
        descriptor.Field(c => c.isDigital).Type<BooleanType>();
        descriptor.Field(c => c.categories).Type<ListType<StringType>>();
        descriptor.Field(c => c.title).Type<StringType>();
        descriptor.Field(c => c.ingress).Type<StringType>();
        descriptor.Field(c => c.starRating).Type<DecimalType>();
        descriptor.Field(c => c.reviews).Type<StringType>();
        descriptor.Field(c => c.likesInProcent).Type<StringType>();
        descriptor.Field(c => c.likesInNumbers).Type<StringType>();
        descriptor.Field(c => c.hours).Type<StringType>();
        descriptor.Field(c => c.Authors).Type<ListType<AuthorType>>();
        descriptor.Field(c => c.Prices).Type<PriceType>();
        descriptor.Field(c => c.Content).Type<ContentType>();
    }
}

public class AuthorType : ObjectType<AuthorEntity>
{
    protected override void Configure(IObjectTypeDescriptor<AuthorEntity> descriptor)
    {
        descriptor.Field(c => c.author).Type<StringType>();
    }
}


public class PriceType : ObjectType<PricesEntity>
{
    protected override void Configure(IObjectTypeDescriptor<PricesEntity> descriptor)
    {
        descriptor.Field(c => c.currency).Type<StringType>();
        descriptor.Field(c => c.price).Type<DecimalType>();
        descriptor.Field(c => c.discountPrice).Type<DecimalType>();
    }
}

public class ContentType : ObjectType<ContentEntity>
{
    protected override void Configure(IObjectTypeDescriptor<ContentEntity> descriptor)
    {
        descriptor.Field(c => c.description).Type<StringType>();
        descriptor.Field(c => c.includes).Type<ListType<StringType>>();
        descriptor.Field(c => c.ProgramDetails).Type<ListType<ProgramDetailItemType>>();
    }
}

public class ProgramDetailItemType : ObjectType<ProgramDetailItemEntity>
{
    protected override void Configure(IObjectTypeDescriptor<ProgramDetailItemEntity> descriptor)
    {
        descriptor.Field(c => c.id).Type<IntType>();
        descriptor.Field(c => c.title).Type<StringType>();
        descriptor.Field(c => c.description).Type<StringType>();
    }
}