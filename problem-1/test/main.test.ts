import { describe, expect, test } from '@jest/globals';
import { findPermutations } from "../main";

describe("findMutation", () => {
    const doArraysIntersect
        = (array1: string[], array2: string[]) => array1.some(item1 => array2.includes(item1))

    test("Input : 'a'", () => {
        const result = findPermutations("a");
        expect(doArraysIntersect(result, ["a"])).toBe(true);
    });

    test("Input : 'ab'", () => {
        const result = findPermutations("ab");
        expect(doArraysIntersect(result, ["ab", "ba"])).toBe(true);
    });

    test("Input : 'abc'", () => {
        const result = findPermutations("abc");
        expect(doArraysIntersect(result, ['abc', 'acb', 'bac', 'bca', 'cab', 'cba'])).toBe(true);
    });

    test("Input : 'aabb'", () => {
        const result = findPermutations("aabb");
        expect(doArraysIntersect(result, ['aabb', 'abab', 'abba', 'baab', 'baba', 'bbaa'])).toBe(true);
    });
});
