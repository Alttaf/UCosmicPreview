﻿namespace UCosmic.Domain.Establishments
{
    public class GetEstablishmentByEmailHandler : IHandleQueries<GetEstablishmentByEmailQuery, Establishment>
    {
        private readonly IQueryEntities _entities;

        public GetEstablishmentByEmailHandler(IQueryEntities entities)
        {
            _entities = entities;
        }

        public Establishment Handle(GetEstablishmentByEmailQuery query)
        {
            return _entities.Establishments
                .EagerLoad(query.EagerLoad, _entities)
                .ByEmail(query.Email)
            ;
        }
    }
}