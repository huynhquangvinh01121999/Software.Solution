﻿using Application.DTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Mappings
{
    public static class CustomerProfile
    {
        // convert entity -> dto
        public static CustomerDto MappingCustomerDto(this Customers customer)
        {
            return new CustomerDto
            {
                Id = customer.Id,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Contact = customer.Contact,
                Email = customer.Email,
                DateOfBirth = customer.DateOfBirth,
                Created = customer.Created
            };
        }

        // convert entity -> dto
        public static Customers MappingCustomer(this CustomerDto customerDto)
        {
            return new Customers
            {
                FirstName = customerDto.FirstName,
                LastName = customerDto.LastName,
                Contact = customerDto.Contact,
                Email = customerDto.Email,
                DateOfBirth = customerDto.DateOfBirth
            };
        }

        // hàm gán giá trị của Product = ProductDTO
        public static void MappingCustomer(this CustomerDto customerDto, Customers customer)
        {
            customer.FirstName = customerDto.FirstName;
            customer.LastName = customerDto.LastName;
            customer.Contact = customerDto.Contact;
            customer.Email = customerDto.Email;
            customer.DateOfBirth = customerDto.DateOfBirth;
        }



        // hàm trả về danh sách ProductDTO và thực thi gán value của từng đối tượng Product cho ProductDTO
        public static IEnumerable<CustomerDto> MappingCustomeDtos(this IEnumerable<Customers> customers)
        {
            foreach (var customer in customers)
            {
                yield return customer.MappingCustomerDto();
            }
        }
    }
}
