using System;
using System.Collections.Generic;
using System.Linq;

public static class ExtentionClass
{
    public static List<Student> ExtentionCount(this IList<Student> marks)
    {
        var result =
            from mark in marks
            where (mark.Marks.Count(x => x == 2) == 2)
            select mark;
        return result.ToList();
    }

}