using FluentValidation;

namespace MathAndFun;

internal class SudokuSolutionValidator : AbstractValidator<SudokuSolution>
{
    public SudokuSolutionValidator()
    {
        RuleFor(x => x.Rows).Must(AllBeValidSudokuSets).WithMessage("{PropertyName} are invalid");
        RuleFor(x => x.Columns).Must(AllBeValidSudokuSets).WithMessage("{PropertyName} are invalid");
        RuleFor(x => x.Blocks).Must(AllBeValidSudokuSets).WithMessage("{PropertyName} are invalid");
        RuleFor(x => x.Diagonals).Must(AllBeValidSudokuSets).WithMessage("{PropertyName} are invalid");
    }

    private bool AllBeValidSudokuSets(IEnumerable<IEnumerable<int>> sets)
    {
        return sets.All(set => BeAValidSudokuSet(set));
    }

    private bool BeAValidSudokuSet(IEnumerable<int> ints)
    {
        HashSet<int> hashSet = new();
        foreach (int i in ints)
        {
            if (hashSet.Contains(i))
            {
                return false;
            }
            hashSet.Add(i);
        }
        return true;
    }
}