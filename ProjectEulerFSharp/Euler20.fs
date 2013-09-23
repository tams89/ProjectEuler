namespace Euler

module Euler20 = 
    
    let factorialSum : bigint = 
        let mutable sum = 0I
        let mutable multiple = 1I
        let factorial = 
            for i = 100 downto 1 do
                multiple <- multiple * bigint(i)
            multiple
        let sumOfDigits = 
            for x in factorial.ToString() do
                sum <- sum + bigint.Parse(x.ToString())
        sum