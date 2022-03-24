export class IEmployee{
    name: string;
    annualPay: number;
    dependents : Dependent[]
}
export class Dependent{
    type: number;
    name: string
}
export class BenefitSummary{
    annualBenefitCost: string;
    payCheckBenefitCosts: []
}
export class PayCheckBenefit{
    payCheckId: string;
    payCheckBenefitCost: string
}