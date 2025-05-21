using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DatabaseManagement.Interfaces
{
    public interface IEvaluationInterface
    {
        public void saveEvaluation(Evaluation evaluation);
        public List<Evaluation> loadEvaluations();
        public Evaluation getEvaluationById(int id);
        public int getLatestID();
        public int getLatestID_Question();
        public void updateEvaluation(Evaluation evaluation);
        public void destroyEvaluation(Evaluation evaluation);
        public List<Evaluation> removeDuplicates(List<Evaluation> evaluations);
        public List<Question> removeQuestionsDuplicates(List<Question> questions);
    }
}
