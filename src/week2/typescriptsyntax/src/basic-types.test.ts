import { describe, expect, it } from 'vitest';

describe('Types in TypeScript', () => {
    describe('Implicit Typing', () => {
        it('An Example', () => {
            let a = 10, b = 20, answer;

            answer = a + b;

            expect(answer).toBe(30);
        })

        it('Implicit Typing When you Initialize a Variabe', () => {

            type AgeType = 'Minor' | 'Adult'; // Type Alias
            let age: number | AgeType = 54; // age can be either a number or AgeType

            age = 'Adult';

            expect(age).toBe('Adult');


            let name:string;
            name = 'Pedro';


        });

        it('For arrays', () => {
            let ingredients: string[];
            let color: Array<string>;
            ingredients = ['Water', 'Egg']
            expect(ingredients[0]).toBe('Water');

        })
    })
})
