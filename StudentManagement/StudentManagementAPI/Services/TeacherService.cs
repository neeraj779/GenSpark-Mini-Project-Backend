﻿using StudentManagementAPI.Exceptions;
using StudentManagementAPI.Interfaces;
using StudentManagementAPI.Models.DBModels;
using StudentManagementAPI.Models.DTOs;

namespace StudentManagementAPI.Services
{
    public class TeacherService : ITeacherService
    {
        private readonly IRepository<int, Teacher> _teacherRepository;

        public TeacherService(IRepository<int, Teacher> teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        public async Task<TeacherReturnDTO> RegisterTeacher(TeacherRegisterDTO teacher)
        {
            try
            {
                Teacher newTeacher = new Teacher();
                newTeacher.FullName = teacher.FullName;
                newTeacher.DateOfBirth = teacher.DateOfBirth;
                newTeacher.Gender = teacher.Gender;
                newTeacher.Phone = teacher.Phone;
                newTeacher.Email = teacher.Email;

                await _teacherRepository.Add(newTeacher);

                return MapTeacherToTeacherReturnDTO(newTeacher);
            }

            catch (UnableToAddException)
            {
                throw new UnableToAddException("Unable to Register Teacher. Please check the data and try again.");
            }
        }

        public async Task<TeacherReturnDTO> UpdateTeacher(Teacher teacher)
        {
            try
            {
                var updatedTeacher = await _teacherRepository.Update(teacher);
                return MapTeacherToTeacherReturnDTO(updatedTeacher);
            }
            catch (NoSuchTeacherException)
            {
                throw new NoSuchTeacherException();
            }
        }

        public async Task<TeacherReturnDTO> UpdateTeacherEmail(UpdateEmailDTO updateEmaildto)
        {
            var teacher = await _teacherRepository.Get(updateEmaildto.Id);
            if (teacher == null)
                throw new NoSuchTeacherException();

            teacher.Email = updateEmaildto.Email;
            await _teacherRepository.Update(teacher);

            return MapTeacherToTeacherReturnDTO(teacher);
        }

        public async Task<TeacherReturnDTO> UpdateTeacherPhone(UpdatePhoneDTO updatePhonedto)
        {
            var teacher = await _teacherRepository.Get(updatePhonedto.Id);
            if (teacher == null)
                throw new NoSuchTeacherException();

            teacher.Phone = updatePhonedto.Phone;
            await _teacherRepository.Update(teacher);

            return MapTeacherToTeacherReturnDTO(teacher);
        }

        public async Task<TeacherReturnDTO> GetTeacherById(int key)
        {
            var teacher = await _teacherRepository.Get(key);
            if (teacher == null)
                throw new NoSuchTeacherException();

            return MapTeacherToTeacherReturnDTO(teacher);
        }

        public async Task<IEnumerable<TeacherReturnDTO>> GetTeachers()
        {
            var teachers = await _teacherRepository.Get();
            if (teachers.Count() == 0)
                throw new NoTeacherFoundException();

            var teacherDTOs = new List<TeacherReturnDTO>();
            foreach (var teacher in teachers)
                teacherDTOs.Add(MapTeacherToTeacherReturnDTO(teacher));
            return teacherDTOs;
        }

        public async Task<TeacherReturnDTO> DeleteTeacher(int teacherId)
        {
            var isTeacherExist = await _teacherRepository.Get(teacherId);
            if (isTeacherExist == null)
                throw new NoSuchTeacherException();

            var teacher = await _teacherRepository.Delete(teacherId);
            return MapTeacherToTeacherReturnDTO(teacher);
        }


        private TeacherReturnDTO MapTeacherToTeacherReturnDTO(Teacher newTeacher)
        {
            TeacherReturnDTO teacherReturnDTO = new TeacherReturnDTO();
            teacherReturnDTO.TeacherId = newTeacher.TeacherId;
            teacherReturnDTO.FullName = newTeacher.FullName;
            teacherReturnDTO.DateOfBirth = newTeacher.DateOfBirth;
            teacherReturnDTO.Gender = newTeacher.Gender;
            teacherReturnDTO.Phone = newTeacher.Phone;
            teacherReturnDTO.Email = newTeacher.Email;

            return teacherReturnDTO;
        }
    }
}
