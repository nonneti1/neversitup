export function findOdd(arrNumber: number[]): number {
    const counter: Record<string, number> = {};

    for (const number of arrNumber) {
        if (counter[number] == null) {
            counter[number] = 1
        } else {
            counter[number]++;
        }
    }

    for (const key in counter) {
        const isOdd = counter[key] % 2 != 0
        if (isOdd == true) return Number(key);
    }
    return 0;
}

const input = [0,1,0,1,0];
const result = findOdd(input);
console.log(result);