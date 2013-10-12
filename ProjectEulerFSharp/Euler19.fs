namespace Euler

(*
    1 Jan 1900 was a Monday.
    Thirty days has September,
    April, June and November.
    All the rest have thirty-one,
    Saving February alone,
    Which has twenty-eight, rain or shine.
    And on leap years, twenty-nine.
    A leap year occurs on any year evenly divisible by 4, but not on a century unless it is divisible by 400.
    How many Sundays fell on the first of the month during the twentieth century (1 Jan 1901 to 31 Dec 2000)?
*)

module Euler19 =

    /// Collection of the days in a particular month.
    let answer startYear endYear =
        let mutable sundayCount = 0
        for yearCounter = startYear to endYear do
            for monthCounter = 1 to 12 do
                let theDay = new System.DateTime(yearCounter, monthCounter, 1)
                if theDay.DayOfWeek = System.DayOfWeek.Sunday then sundayCount <- sundayCount + 1
        printfn "Number of sundays between 1 Jan 1901 - 31 Dec 2000 occuring on the first of a month is: %A" sundayCount
        sundayCount