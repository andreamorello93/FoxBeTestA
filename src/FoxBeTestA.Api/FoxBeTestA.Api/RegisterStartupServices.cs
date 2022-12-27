
using System.Reflection;
using AutoMapper;
using FoxBeTestA.Application.Automapper;
using FoxBeTestA.Application.DTOs;
using FoxBeTestA.Application.Interfaces;
using FoxBeTestA.Application.Processors;
using FoxBeTestA.Application.Repositories;
using FoxBeTestA.DAL.Data;
using FoxBeTestA.DAL.Models;
using Microsoft.EntityFrameworkCore;
using MediatR;


public static class RegisterStartupServices
{
    public static WebApplicationBuilder RegisterServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        AddRepositories(builder);

        AddProcessors(builder);

        AddMediatR(builder);

        AddAutoMapper(builder);

        AddDbContext(builder);

        return builder;
    }

    private static void AddDbContext(WebApplicationBuilder builder)
    {
        builder.Services.AddDbContext<FoxBeTestAContext>(opts => 
            opts.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"), 
            assembly => assembly.MigrationsAssembly(typeof(FoxBeTestAContext).Assembly.FullName)));
    }

    private static void AddAutoMapper(WebApplicationBuilder builder)
    {
        var mapperConfig = new MapperConfiguration(mc => { mc.AddProfile(new MappingProfile()); });

        IMapper mapper = mapperConfig.CreateMapper();
        builder.Services.AddSingleton(mapper);
    }

    private static void AddMediatR(WebApplicationBuilder builder)
    {
        builder.Services.AddMediatR(Assembly.Load("FoxBeTestA.Application"));
    }

    private static void AddProcessors(WebApplicationBuilder builder)
    {
        builder.Services.AddTransient<IGenericProcessor<Accomodation, AccomodationDto, int>, AccomodationProcessor>();
        builder.Services.AddTransient<IRoomTypeProcessor, RoomTypeProcessor>();
        builder.Services.AddTransient<IGenericProcessor<PriceList, PriceListDto, int>, PriceListProcessor>();
    }

    private static void AddRepositories(WebApplicationBuilder builder)
    {
        builder.Services.AddTransient<IGenericRepository<Accomodation, int>, AccomodationRepository>();
        builder.Services.AddTransient<IRoomTypeRepository, RoomTypeRepository>();
        builder.Services.AddTransient<IGenericRepository<PriceList, int>, PriceListRepository>();
    }
}

