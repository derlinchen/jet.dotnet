using jet.Bean;
using jet.Bean.BaseDic;

namespace jet.Repository.interfaces
{
	public interface IBaseDicRepository
	{
		void SaveItem(BaseDic item);
		void DeleteItemById(string id);
		void UpdateItem(BaseDic item);
		BaseDicVo? GetBaseDic(string id);
		List<BaseDicVo> GetBaseDicList(BaseDicDto item);
		PageInfo<BaseDicVo> SearchBaseDic(PageSearch<BaseDicDto> item);
	}
}
