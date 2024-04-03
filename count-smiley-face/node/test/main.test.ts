import { describe, expect, test } from '@jest/globals';
import { countSmileyFace } from '../main';

describe("Odd", () => {
    test("Input : [':)', ';(', ';}', ':-D'] should return 2", () => {
        const result = countSmileyFace([':)', ';(', ';}', ':-D']);
        expect(result).toEqual(2);
    });

    test("Input : [';D', ':-(', ':-)', ';~)'] should return 3", () => {
        const result = countSmileyFace([';D', ':-(', ':-)', ';~)']);
        expect(result).toEqual(3);
    });

    test("Input : [';]', ':[', ';*', ':$', ';-D'] should return 1", () => {
        const result = countSmileyFace([';]', ':[', ';*', ':$', ';-D']);
        expect(result).toEqual(1);
    });
});
