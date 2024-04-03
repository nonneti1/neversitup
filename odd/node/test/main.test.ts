import { describe, expect, test } from '@jest/globals';
import { findOdd } from '../main';

describe("Odd", () => {
    test("Input : [7] should return 7", () => {
        const result = findOdd([7]);
        expect(result).toEqual(7);
    });

    test("Input : [0] should return 0", () => {
        const result = findOdd([0]);
        expect(result).toEqual(0);
    });

    test("Input : [1,1,2] should return 2", () => {
        const result = findOdd([1, 1, 2]);
        expect(result).toEqual(2);
    });

    test("Input : [0,1,0,1,0] should return 0", () => {
        const result = findOdd([0, 1, 0, 1, 0]);
        expect(result).toEqual(0);
    });

    test("Input : [1,2,2,3,3,3,4,3,3,3,2,2,1] should return 4", () => {
        const result = findOdd([1,2,2,3,3,3,4,3,3,3,2,2,1]);
        expect(result).toEqual(4);
    });

});
