using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using laptopEcommerce.Data.Enums;
using laptopEcommerce.Models;
using Microsoft.Extensions.DependencyInjection;

//for giving database inputs (seeding data)
namespace laptopEcommerce.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();


                //for Laptop company :

                //if no entry found
                if (!context.laptop_company_variable.Any())
                {
                    context.laptop_company_variable.AddRange(new List<Laptop_company>()
                    {
                        new Laptop_company()
                        {
                            Name = "Acer",
                            Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/00/Acer_2011.svg/220px-Acer_2011.svg.png",
                            Description = "This laptop is made by Acer. Acer Inc. (/ˈeɪsər/ AY-sər) is a Taiwanese multinational hardware and electronics corporation specializing in advanced electronics technology, headquartered in Xizhi, New Taipei City. Its products include desktop PCs, laptop PCs (clamshells, 2-in-1s, convertibles and Chromebooks), tablets, servers, storage devices, virtual reality devices, displays, smartphones and peripherals, as well as gaming PCs and accessories under its Predator brand. Acer is the world's 6th-largest PC vendor by unit sales as of January 2021.In the early 2000s, Acer implemented a new business model, shifting from a manufacturer to a designer, marketer, and distributor of products, while performing production processes via contract manufacturers. Currently, in addition to its core IT products business, Acer also has a new business entity that focuses on the integration of cloud services and platforms, and the development of smartphones and wearable devices with value-added IoT applications."
                        },
                        new Laptop_company()
                        {
                            Name = "Apple",
                            Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fa/Apple_logo_black.svg/80px-Apple_logo_black.svg.png",
                            Description = "This laptop is made by Apple. Apple Inc. is an American multinational technology company that specializes in consumer electronics, software and online services headquartered in Cupertino, California, United States. Apple is the largest technology company by revenue (totaling US$365.8 billion in 2021) and as of June 2022, is the world's biggest company by market capitalization, the fourth-largest personal computer vendor by unit sales and second-largest mobile phone manufacturer. It is one of the Big Five American information technology companies, alongside Alphabet, Amazon, Meta, and Microsoft."
                        },
                        new Laptop_company()
                        {
                            Name = "HP",
                            Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ad/HP_logo_2012.svg/120px-HP_logo_2012.svg.png" ,
                            Description = "This laptop is made by HP. HP provides a lot of laptop series like elitebook, envy, omen, pavilion, zbook, etc. HP provides laptop of all categories"
                        },
                        new Laptop_company()
                        {
                            Name = "Lenovo",
                            Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/01/Lenovo_logo_%282015_onwards%29_2.svg/220px-Lenovo_logo_%282015_onwards%29_2.svg.png",
                            Description = "Lenovo Group Limited, often shortened to Lenovo (/ləˈnoʊvoʊ/ lə-NOH-voh, Chinese: 联想; pinyin: Liánxiǎng), is a Chinese[8] multinational technology company specializing in designing, manufacturing, and marketing consumer electronics, personal computers, software, business solutions, and related services. Products manufactured by the company include desktop computers, laptops, tablet computers, smartphones, workstations, servers, supercomputers, electronic storage devices, IT management software, and smart televisions. Its best-known brands include its ThinkPad business line of laptop computers (acquired from IBM), the IdeaPad, Yoga, and Legion consumer lines of laptop computers, and the IdeaCentre and ThinkCentre lines of desktop computers. As of 2021, Lenovo is the world's largest personal computer vendor by unit sales."
                        },
                        new Laptop_company()
                        {
                            Name = "Dell",
                            Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/18/Dell_logo_2016.svg/150px-Dell_logo_2016.svg.png",
                            Description = "Dell (/ˈdɛl/) is an American multinational technology company that develops, sells, repairs, and supports computers and related products and services and is owned by its parent company, Dell Technologies.Dell sells personal computers (PCs), servers, data storage devices, network switches, software, computer peripherals, HDTVs, cameras, printers, and electronics built by other manufacturers. The company is known for how it manages its supply chain and electronic commerce. This includes Dell selling directly to customers and delivering PCs that the customer wants. Dell was a pure hardware vendor until 2009 when it acquired Perot Systems. Dell then entered the market for IT services. The company has expanded storage and networking systems, now aiming to expand from offering computers only to delivering a range of technology for enterprise customers."
                        },
                    });
                    context.SaveChanges();
                }

                //for Laptop Specs :

                //if no entry found
                if (!context.laptop_Specs.Any())
                {
                    context.laptop_Specs.AddRange(new List<Laptop_specs>()
                    {
                        new Laptop_specs()
                        {
                            Laptop_Name = "IdeaPad 5",
                            Laptop_Description = "IdeaPad (stylized as ideapad) is a line of consumer-oriented laptop computers designed, developed and marketed by Lenovo. The IdeaPad mainly competes against computers such as Acer's Aspire, Dell's Inspiron and XPS, HP's Pavilion, Envy and Stream, Samsung's Sens and Toshiba's Satellite.",
                            price = 57549,
                            ImageUrl = "https://p3-ofp.static.pub/ShareResource/na/subseries/hero/lenovo-ideapad-5i-gen7-amd-02.png",
                            Laptop_cpu = "AMD Ryzen™ 7 5825U Processor (2.00 GHz up to 4.50 GHz Max Boost, 8 Cores, 16 Threads, 16 MB Cache)",
                            Laptop_gpu = "Integrated AMD Radeon™ graphics",
                            LaptopCategory = LaptopCategory.Office_use,
                            Laptop_company_id = 4

                        },

                        new Laptop_specs()
                        {
                            Laptop_Name = "Legion 7i Gen 6 (16” Intel) Gaming Laptop",
                            Laptop_Description = "16″ WQXGA gaming display, @ up to 165Hz. 3D Nahimic audio lets you hear every footstep that approaches. Play over 100 high-quality PC games with your new Legion PC and 3 free months of Xbox Game Pass",
                            price = 249990,
                            ImageUrl = "https://p4-ofp.static.pub/fes/cms/2022/03/28/0mju4qzxqrugzwlk0mnjquevubmenf857772.png",
                            Laptop_cpu = "11th Generation Intel® Core™ i7-11800H Processor (2.30 GHz, up to 4.60 GHz with Turbo Boost, 8 Cores, 16 Threads, 24 MB Cache)",
                            Laptop_gpu = "NVIDIA® GeForce® RTX™ 3080 16GB",
                            LaptopCategory = LaptopCategory.Gaming,
                            Laptop_company_id = 4

                        },

                        new Laptop_specs()
                        {
                            Laptop_Name = "HP EliteBook x360 1040 G8 Notebook PC - Customizable",
                            Laptop_Description = "14 FHD (1920x1080) Touchscreen displayThe sleek, thin, and light HP EliteBook x360 1040 transforms to the workstyle of your choice. A powerful processor, wireless connections, and strong security helps keep you safely connected with co-workers and clients",
                            price = 127136,
                            ImageUrl = "https://ssl-product-images.www8-hp.com/digmedialib/prodimg/lowres/c07983640.png",
                            Laptop_cpu = "11th Generation Intel® Core™ i5 processor",
                            Laptop_gpu = "Intel® Iris® Xe Graphics",
                            LaptopCategory = LaptopCategory.Office_use,
                            Laptop_company_id = 3

                        },

                       

                        new Laptop_specs()
                        {
                            Laptop_Name = "MacBook Air",
                            Laptop_Description = "33.74 cm Retina display, Up to 16GB unified memory, 2 TB Maximum configurable storage, Up to 18 hours battery life, 720p FaceTime HD camera, 1.29 kg",
                            price = 99900,
                            ImageUrl = "https://imgs.search.brave.com/rM57YjCXtP-KotUeRomz7S-WkQ0ys8X-thlhauiOcSc/rs:fit:1200:1200:1/g:ce/aHR0cHM6Ly9tYWdh/emluZWNsb25lcmVw/dWIuYmxvYi5jb3Jl/LndpbmRvd3MubmV0/L21jZXB1Yi8zNDU3/LzIwOTM3MC9pbWFn/ZS8zZmZmNWY5Yy01/ZWExLTQzMjctYTcz/OC1lNzk1NGJkMGIx/OGEuanBn",
                            Laptop_cpu = "Apple M1 chip 8-core CPU",
                            Laptop_gpu = "Apple M1 chip 7-core GPU",
                            LaptopCategory = LaptopCategory.Office_use,
                            Laptop_company_id = 2

                        },

                        new Laptop_specs()
                        {
                            Laptop_Name = "MacBook Pro",
                            Laptop_Description = "41.05 cm Liquid Retina display, Up to 64GB unified memory, 8 TB Maximum configurable storage, Up to 21 hours battery life, 1080p FaceTime HD camera, 2.1 kg",
                            price = 194900,
                            ImageUrl = "https://imgs.search.brave.com/B_697wXVhiyeSSY8xu6Ju7we9Jtdw9hTmRvHAdb4HME/rs:fit:1200:1200:1/g:ce/aHR0cHM6Ly93d3cu/YmhwaG90b3ZpZGVv/LmNvbS9pbWFnZXMv/aW1hZ2VzMjUwMHgy/NTAwL2FwcGxlX21i/cF8xNF9zZ18yNF8x/NF8yX21hY2Jvb2tf/cHJvX3dpdGhfMTY2/ODIyNC5qcGc",
                            Laptop_cpu = "Apple M1 max chip 10-core CPU",
                            Laptop_gpu = "Apple M1 max chip 32-core GPU",
                            LaptopCategory = LaptopCategory.Editting,
                            Laptop_company_id = 2

                        },

                        new Laptop_specs()
                        {
                            Laptop_Name = "Dell 15 (2021)",
                            Laptop_Description = "8GB, 256GB SSD, Windows 10 + MS Office, 15.6 inches(39cm) FHD Display, Soft Mint Color (Inspiron 3505, D560618WIN9SE), 1.83kg",
                            price = 39690,
                            ImageUrl = "https://m.media-amazon.com/images/W/WEBP_402378-T2/images/I/51TACuT6SNL._SY450_.jpg",
                            Laptop_cpu = "AMD Ryzen 3-3250U",
                            Laptop_gpu = "Radeon Graphics",
                            LaptopCategory = LaptopCategory.Office_use,
                            Laptop_company_id = 5

                        },

                        new Laptop_specs()
                        {
                            Laptop_Name = "Acer Aspire 5",
                            Laptop_Description = "(8 GB/512 GB SSD/Windows 11 Home / model : A515-57G / Gaming Laptop (15.6 inch, Steel Gray 1.8 Kg",
                            price = 58990,
                            ImageUrl = "https://m.media-amazon.com/images/W/WEBP_402378-T2/images/I/51NqWEixtLL._SY450_.jpg",
                            Laptop_cpu = "12th Gen Intel Core i5-(12 cores)",
                            Laptop_gpu = "NVIDIA GeForce RTX 2050 (4 GB)",
                            LaptopCategory = LaptopCategory.Gaming,
                            Laptop_company_id = 1

                        },




                    });



                    context.SaveChanges();

                }


            }
        }
    }
}
